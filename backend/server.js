const express = require('express');
const axios = require('axios');
const cors = require('cors');
require('dotenv').config();

const app = express();
const port = 3000;

app.use(cors());
app.use(express.json());

const OPENAI_API_KEY = process.env.OPENAI_API_KEY;

const educationKeywords = [
    'course', 'class', 'teacher', 'professor', 'university', 'college', 'school',
    'exam', 'test', 'study', 'syllabus', 'homework', 'assignment', 'lecture',
    'student', 'textbook', 'grade', 'semester', 'tuition', 'scholarship'
];

function isEducationRelated(message) {
    return educationKeywords.some(keyword => message.toLowerCase().includes(keyword));
}

app.post('/api/chat', async (req, res) => {
    const { message } = req.body;

    if (!isEducationRelated(message)) {
        return res.json({ reply: "I'm sorry, but I can only answer questions related to education." });
    }

    try {
        const response = await axios.post(
            'https://api.openai.com/v1/chat/completions',
            {
                messages: [
                    { 
                        role: 'system', 
                        content: 'You are a chat bot that only answers educational questions about Edge Hill University. You are only accessed by students during Freshers week to answer their questions. Use the latest factual information exclusively.'
                    }, 
                    { 
                        role: 'user', 
                        content: message 
                    }],
                model: 'gpt-3.5-turbo-0125',
                max_tokens: 150,
                temperature: 0.7
            },
            {
                headers: {
                    'Content-Type': 'application/json',
                    'Authorization': `Bearer ${OPENAI_API_KEY}`
                }
            }
        );

        const responseData = response.data;
        if (responseData && responseData.choices && responseData.choices.length > 0) {
            const reply = responseData.choices[0].message.content.trim();
            res.json({ reply });
        } else {
            console.error('Invalid response format from OpenAI:', responseData);
            res.status(500).send('Invalid response format from OpenAI');
        }
    } catch (error) {
        console.error('Error communicating with OpenAI:', error.response ? error.response.data : error.message);
        res.status(500).send('Error communicating with OpenAI');
    }
});

app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}/client/`);
});
