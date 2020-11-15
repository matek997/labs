

(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];
    const addNewItem = async () => {
        const formData = new FormData(document.querySelector('form'))

        const formvals = {}
        for (const pair of formData.entries()) {
            formvals[pair[0]] = pair[1];
        }
        formvals.IsVisible = formvals.IsVisible == 'true' ? true : false;
        const requestData = {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
                // 'Content-Type': 'application/x-www-form-urlencoded',
            },
            body: JSON.stringify(formvals)
        };
        const response = await fetch('/api/Ajax', requestData);
        const responseJson = await response.json();
        if (responseJson.success) {
            alertElement.style.display = 'block';
        }
    };
    window.addEventListener("DOMContentLoaded", () => {
        formElement.addEventListener("submit",
            event => {
                event.preventDefault();
                addNewItem().then(() => console.log("added successfully"));
            });
    });
})();