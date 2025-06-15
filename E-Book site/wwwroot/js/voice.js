window.voiceToText = {
    start: function (dotNetRef) {
        if (!('webkitSpeechRecognition' in window)) {
            alert('Sorry, your browser does not support voice recognition.');
            dotNetRef.invokeMethodAsync("SetSearchTerm", "");
            return;
        }

        const recognition = new (window.SpeechRecognition || window.webkitSpeechRecognition)();
        recognition.lang = 'en-US';
        recognition.interimResults = false;
        recognition.maxAlternatives = 1;

        recognition.onstart = () => {
            console.log("Voice recognition started. Speak now.");
        };

        recognition.onresult = (event) => {
            const transcript = event.results[0][0].transcript;
            dotNetRef.invokeMethodAsync("SetSearchTerm", transcript);
        };

        recognition.onerror = (event) => {
            console.error("Speech recognition error:", event.error);
            dotNetRef.invokeMethodAsync("SetSearchTerm", "");
        };

        recognition.onend = () => {
            console.log("Voice recognition ended.");
        };

        recognition.start();
    }
};