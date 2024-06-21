"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
var express_1 = __importDefault(require("express"));
var body_parser_1 = __importDefault(require("body-parser"));
var fs_1 = __importDefault(require("fs"));
var path_1 = __importDefault(require("path"));
var app = (0, express_1.default)();
var port = 3000;

// Middleware
app.use(body_parser_1.default.json());
app.use(body_parser_1.default.urlencoded({ extended: true }));

var submissions = [];

// Load submissions from the JSON file
var dbFilePath = path_1.default.join(__dirname, 'db.json');
try {
    var dbData = fs_1.default.readFileSync(dbFilePath, 'utf8');
    submissions = JSON.parse(dbData);
} catch (err) {
    console.error('Error reading the database file:', err);
}

// Save submissions to the JSON file
function saveSubmissions() {
    var dbData = JSON.stringify(submissions, null, 2);
    fs_1.default.writeFileSync(dbFilePath, dbData, 'utf8');
}

// Ping endpoint
app.get('/ping', function (req, res) {
    res.json({ success: true });
});

// Submit endpoint
app.post('/submit', function (req, res) {
    var _a = req.body, name = _a.name, email = _a.email, phone = _a.phone, githubLink = _a.githubLink, stopwatchTime = _a.stopwatchTime;
    if (!name || !email || !phone || !githubLink || !stopwatchTime) {
        return res.status(400).json({ error: 'Missing required fields' });
    }
    var submission = {
        name: name,
        email: email,
        phone: phone,
        githubLink: githubLink,
        stopwatchTime: stopwatchTime,
    };
    submissions.push(submission);
    saveSubmissions();
    res.json({ success: true });
});

// Read all submissions endpoint
app.get('/submissions', function (req, res) {
    res.json(submissions);
});

// Read endpoint
app.get('/read', function (req, res) {
    var index = parseInt(req.query.index, 10);
    if (isNaN(index) || index < 0 || index >= submissions.length) {
        return res.status(400).json({ error: 'Invalid index' });
    }
    var submission = submissions[index];
    res.json(submission);
});

app.listen(port, function () {
    console.log("Server is running on http://localhost:".concat(port));
});

// Update endpoint
app.put('/update', (req, res) => {
    const { index, name, email, phone, githubLink, stopwatchTime } = req.body;
    if (isNaN(index) || index < 0 || index >= submissions.length) {
        return res.status(400).json({ error: 'Invalid index' });
    }
    if (!name || !email || !phone || !githubLink || !stopwatchTime) {
        return res.status(400).json({ error: 'Missing required fields' });
    }
    submissions[index] = { name, email, phone, githubLink, stopwatchTime };
    saveSubmissions();
    res.json({ success: true });
});

// Delete endpoint
app.delete('/delete', (req, res) => {
    const index = parseInt(req.query.index, 10);
    if (isNaN(index) || index < 0 || index >= submissions.length) {
        return res.status(400).json({ error: 'Invalid index' });
    }
    submissions.splice(index, 1);
    saveSubmissions();
    res.json({ success: true });
});

