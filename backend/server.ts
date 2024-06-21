import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import fs from 'fs';
import path from 'path';

const app = express();
const port = 3000;

// Middleware
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

// In-memory database (replace with a proper database solution)
interface Submission {
    name: string;
    email: string;
    phone: string;
    githubLink: string;
    stopwatchTime: string;
}

let submissions: Submission[] = [];

// Load submissions from the JSON file
const dbFilePath = path.join(__dirname, 'db.json');
try {
    const dbData = fs.readFileSync(dbFilePath, 'utf8');
    submissions = JSON.parse(dbData);
} catch (err) {
    console.error('Error reading the database file:', err);
}

// Save submissions to the JSON file
function saveSubmissions() {
    const dbData = JSON.stringify(submissions, null, 2);
    fs.writeFileSync(dbFilePath, dbData, 'utf8');
}

// Ping endpoint
app.get('/ping', (req: Request, res: Response) => {
    res.json({ success: true });
});

// Submit endpoint
app.post('/submit', (req: Request, res: Response) => {
    const { name, email, phone, githubLink, stopwatchTime } = req.body;

    if (!name || !email || !phone || !githubLink || !stopwatchTime) {
        return res.status(400).json({ error: 'Missing required fields' });
    }

    const submission: Submission = {
        name,
        email,
        phone,
        githubLink,
        stopwatchTime,
    };

    submissions.push(submission);
    saveSubmissions();

    res.json({ success: true });
});

// Read endpoint
app.get('/read', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string, 10);

    if (isNaN(index) || index < 0 || index >= submissions.length) {
        return res.status(400).json({ error: 'Invalid index' });
    }

    const submission = submissions[index];
    res.json(submission);
});

app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});