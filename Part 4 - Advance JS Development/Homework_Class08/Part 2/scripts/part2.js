$(document).ready(function () {

    let inputText = $("#inputText");
    let inputButton = $("#inputButton");
    let result = $("#result");


    function onlyString(input) {
        return new Promise((resolve, reject) => {
            setTimeout(() => {
                if (!input || input.length === 0 || typeof (input) !== "string" || Number(input)) {
                    reject(input);
                }
                else {
                    resolve(input);
                }
            }, 4000);
        })
    }

    inputButton.click(function () {
        result.text("");
        let text = inputText.val();
        onlyString(text)
            .then(success => {
                result.text(`Valid input: ${success.toUpperCase()}`)
            })
            .catch(error => {
                result.text(`Invalid input: ${error}`);
            })
    })


})