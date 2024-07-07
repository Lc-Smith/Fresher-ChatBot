body {
    font-family: Arial, sans-serif;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
    background-color: #f0f0f0;
}

#chat-container {
    width: 400px;
    background: white;
    border: 1px solid #ccc;
    border-radius: 8px;
    padding: 16px;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

#chat-box {
    height: 300px;
    overflow-y: auto;
    margin-bottom: 16px;
    border: 1px solid #ccc;
    padding: 8px;
    border-radius: 4px;
    background-color: #fafafa;
}

#user-input {
    width: calc(100% - 60px);
    padding: 8px;
    margin-right: 8px;
}

.message {
    margin-bottom: 8px;
}

button {
    padding: 8px 16px;
}
