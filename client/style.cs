body {
    font-family: Arial, sans-serif;
    margin: 0;
    height: 100vh;
    background-color: #f0f0f0;
    display: flex;
    justify-content: center;
    align-items: center;
}

#container {
    display: grid;
    grid-template-columns: 7.5% 1fr 1fr 1fr;
    grid-template-rows: 10rem 1fr 1fr 15rem;
    width: 100%;
    height: 100%;
}

#bot-logo {
    grid-column: 1 / span 1;
    grid-row: 1 / span 1;
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    background-color: #fff;
    border-right: 1px solid #ccc;
    border-bottom: 1px solid #ccc;
    padding: 16px;
}

#bot-logo img {
    width: 80%;
    height: auto;
}

#site-name {
    text-align: center;
    font-size: 1.2rem;
    font-weight: bold;
    margin-top: 8px;
}

#nav-placeholder {
    grid-column: 1 / span 1;
    grid-row: 2 / span 3;
    display: flex;
    justify-content: center;
    align-items: center;
    text-align: center;
    background-color: #fafafa;
    border-right: 1px solid #ccc;
    padding: 16px;
}

#chat-container {
    grid-column: 2 / span 3;
    grid-row: 1 / span 3;
    display: flex;
    flex-direction: column;
    padding: 16px;
    background: white;
    border-left: 1px solid #ccc;
    border-bottom: 1px solid #ccc;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

#chat-box {
    flex: 1;
    overflow-y: auto;
    border: 1px solid #ccc;
    padding: 8px;
    border-radius: 4px;
    background-color: #fafafa;
}

#chat-box .message.user {
    background-color: #d1f7d1;
    text-align: right;
}

#chat-box .message.bot {
    background-color: #f0f0f0;
    text-align: left;
}

#input-container {
    grid-column: 2 / span 3;
    grid-row: 4 / span 1;
    display: flex;
    align-items: center;
    padding: 16px;
    background-color: #fff;
    border-left: 1px solid #ccc;
    border-top: 1px solid #ccc;
    box-shadow: 0 -2px 5px rgba(0, 0, 0, 0.1);
}

#user-input {
    flex: 1;
    padding: 8px;
    margin-right: 8px;
}

button {
    padding: 8px 16px;
}

.message {
    margin-bottom: 8px;
    padding: 8px;
    border-radius: 5px;
    margin-top: 5px;
}
