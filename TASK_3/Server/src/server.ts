import express, { Request, Response } from 'express'
import fs from 'fs'
import path from 'path'
//import cors from 'cors';
import bodyParser from 'body-parser'

const app = express();
const port = 3000;

const DB_FILE = './db.json';

// Middleware to parse JSON requests
app.use(express.json());

// Middleware
app.use(bodyParser.json());
//app.use(cors());
// Ping endpoint
app.get('/ping', (req: Request, res: Response) => {
    res.json({ success: true });
});



// Submit endpoint
app.post('/submit', (req: Request, res: Response) => {
    const { name, email, phone, github_link, stopwatch } = req.body;

    // Load current submissions
    const newSubmission = { name, email, phone, github_link, stopwatch };


    // Save submissions to file
    saveSubmission(newSubmission);

    res.json({ success: true });
});

// Read endpoint
app.get('/read/:index', (req: Request, res: Response) => {
    console.log(req)
    const { index } = req.params;
    const idx = Number(index);

    if (Number.isNaN(idx)) {
        res.status(400).json({ error: 'Invalid index parameter' });
        return;
    }

    const submissions = loadSubmissions();
    saveSubmissions(submissions)
    console.log('Number of submissions: ${ submissions.length }');

    if (idx >= 0 && idx < submissions.length) {
        res.json(submissions[idx]);
    } else {
        res.status(404).json({ error: 'Submission not found' });
    }
});

// Helper function to load submissions from JSON file
function loadSubmissions() {
    try {
        const data = fs.readFileSync(DB_FILE, 'utf8');
        return JSON.parse(data);
    } catch (error) {
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

function saveSubmission(submission : any) {
    try {
        // Load existing submissions
        let existingData: any[] = [];
        try {
            const existingJson = fs.readFileSync(DB_FILE, 'utf8');
            existingData = JSON.parse(existingJson);
        } catch (error) {
            // Handle file read error if db.json doesn't exist or is empty
            console.error('Error reading existing submissions:', error);
        }

        // Append new submissions
        const newData = existingData.concat(submission);

        // Save combined data to file
        const data = JSON.stringify(newData, null, 2);
        fs.writeFileSync(DB_FILE, data, 'utf8');
    } catch (error) {
        console.error('Error saving submissions:', error);
    }
}

// Delete endpoint
app.delete('/delete/:index', (req: Request, res: Response) => {
    const { index } = req.params;
    const idx = Number(index);

    if (Number.isNaN(idx)) {
        res.status(400).json({ error: 'Invalid index parameter' });
        return;
    }

    const submissions = loadSubmissions();

    if (idx >= 0 && idx < submissions.length) {
        submissions.splice(idx, 1);
        saveSubmissions(submissions);
        res.json({ success: true, message: 'Submission deleted successfully' });
    } else {
        res.status(404).json({ error: 'Submission not found' });
    }
});

// New endpoint to get user by email
app.get('/user/:email', (req: Request, res: Response) => {
    const { email } = req.params;

    // Load current submissions
    const submissions = loadSubmissions();

    // Find user by email
    const user = submissions.find((submission: any) => submission.email === email);

    if (user) {
        res.json(user);
    } else {
        res.status(404).json({ error: 'User not found' });
    }
});

app.post('/update', (req, res) => {
    const { index, name, email, phone, github_link} = req.body;

    // Read the existing data from db.json
    fs.readFile('db.json', 'utf8', (err, data) => {
        if (err) {
            console.error(err);
            return res.status(500).send('Error reading database.');
        }

        const db = JSON.parse(data);

        // Update the record by index
        if (db[index]) {
            db[index] = { name, email, phone, github_link, stopwatch: "00:00:00" };
        } else {
            return res.status(404).send('Index not found.');
        }

        // Write the updated data back to db.json
        fs.writeFile('db.json', JSON.stringify(db, null, 2), (err) => {
            if (err) {
                console.error(err);
                return res.status(500).send('Error writing to database.');
            }

            res.send('Update successful!');
        });
    });
});

// Helper function to save submissions to JSON file
function saveSubmissions(submissions: any[]) {
    try {
        const data = JSON.stringify(submissions, null, 2);
        fs.writeFileSync(DB_FILE, data, 'utf8');
    } catch (error) {
        console.error('Error saving submissions:', error);
    }
}


app.listen(port, () => {
    console.log(`Server started at http://localhost:${port}`);
});