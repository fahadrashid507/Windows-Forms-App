"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const fs_1 = __importDefault(require("fs"));
//import cors from 'cors';
const body_parser_1 = __importDefault(require("body-parser"));
const app = (0, express_1.default)();
const port = 3000;
const DB_FILE = './db.json';
// Middleware to parse JSON requests
app.use(express_1.default.json());
// Middleware
app.use(body_parser_1.default.json());
//app.use(cors());
// Ping endpoint
app.get('/ping', (req, res) => {
    res.json({ success: true });
});
// Submit endpoint
app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch } = req.body;
    // Load current submissions
    const newSubmission = { name, email, phone, github_link, stopwatch };
    // Add new submission
    //submissions.push();
    // Save submissions to file
    saveSubmissions(newSubmission);
    res.json({ success: true });
});
// Read endpoint
app.get('/read/:index', (req, res) => {
    console.log(req);
    const { index } = req.params;
    const idx = Number(index);
    if (Number.isNaN(idx)) {
        res.status(400).json({ error: 'Invalid index parameter' });
        return;
    }
    const submissions = loadSubmissions();
    console.log('Number of submissions: ${ submissions.length }');
    if (idx >= 0 && idx < submissions.length) {
        res.json(submissions[idx]);
    }
    else {
        res.status(404).json({ error: 'Submission not found' });
    }
});
// Helper function to load submissions from JSON file
function loadSubmissions() {
    try {
        const data = fs_1.default.readFileSync(DB_FILE, 'utf8');
        return JSON.parse(data);
    }
    catch (error) {
        console.error('Error loading submissions:', error);
        return [];
    }
}
// Helper function to save submissions to JSON file
/*function saveSubmissions(submissions: any[]) {
    try {
        const data = JSON.stringify(submissions, null, 2);
        fs.writeFileSync(DB_FILE, data, 'utf8');
    } catch (error) {
        console.error('Error saving submissions:', error);
    }
}*/
function saveSubmissions(submission) {
    try {
        // Load existing submissions
        let existingData = [];
        try {
            const existingJson = fs_1.default.readFileSync(DB_FILE, 'utf8');
            existingData = JSON.parse(existingJson);
        }
        catch (error) {
            // Handle file read error if db.json doesn't exist or is empty
            console.error('Error reading existing submissions:', error);
        }
        // Append new submissions
        const newData = existingData.concat(submission);
        // Save combined data to file
        const data = JSON.stringify(newData, null, 2);
        fs_1.default.writeFileSync(DB_FILE, data, 'utf8');
    }
    catch (error) {
        console.error('Error saving submissions:', error);
    }
}
// Helper function to save submissions to JSON file
function saveAllSubmissions(submissions) {
    try {
        const data = JSON.stringify(submissions, null, 2);
        fs_1.default.writeFileSync(DB_FILE, data, 'utf8');
    }
    catch (error) {
        console.error('Error saving submissions:', error);
    }
}
// Delete endpoint
app.delete('/delete/:index', (req, res) => {
    const { index } = req.params;
    const idx = Number(index);
    if (Number.isNaN(idx)) {
        res.status(400).json({ error: 'Invalid index parameter' });
        return;
    }
    const submissions = loadSubmissions();
    if (idx >= 0 && idx < submissions.length) {
        submissions.splice(idx, 1); // Remove the submission at the given index
        saveAllSubmissions(submissions); // Save the updated list back to the file
        res.json({ success: true });
    }
    else {
        res.status(404).json({ error: 'Submission not found' });
    }
});
app.listen(port, () => {
    console.log(`Server started at http://localhost:${port}`);
});
