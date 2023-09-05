let secretNumber = generateRandomNumber();
let score = 10;
let highscore = 0;

function generateRandomNumber() {
    return Math.floor(Math.random() * 100) + 1;
}

function updateScore() {
    document.getElementById('score').textContent = score;
}

document.getElementById('guess-btn').addEventListener('click', function() {
    const guess = parseInt(document.getElementById('guess').value);

    if (!guess) {
        alert('Ingresa un número válido.');
        return;
    }

    if (guess === secretNumber) {
        document.getElementById('result').textContent = `¡Adivinaste! El número era ${secretNumber}.`;
        document.getElementById('result').style.color = 'green';

        if (score > highscore) {
            highscore = score;
            document.getElementById('highscore').textContent = highscore;
        }
    } else {
        if (guess > secretNumber) {
            document.getElementById('result').textContent = 'Demasiado alto. Intenta de nuevo.';
        } else {
            document.getElementById('result').textContent = 'Demasiado bajo. Intenta de nuevo.';
        }
        document.getElementById('result').style.color = 'red';
        score--;
        updateScore();
    }

    if (score === 0) {
        document.getElementById('result').textContent = `Perdiste. El número era ${secretNumber}.`;
        document.getElementById('result').style.color = 'red';
        document.getElementById('guess-btn').disabled = true;
    }
});

document.getElementById('reset-btn').addEventListener('click', function() {
    secretNumber = generateRandomNumber();
    score = 10;
    updateScore();
    document.getElementById('result').textContent = '';
    document.getElementById('result').style.color = 'black';
    document.getElementById('guess').value = '';
    document.getElementById('guess-btn').disabled = false;
});