(function () {
    const tableBody = document.getElementById('table-body');
    const tableHead = document.getElementById('table-head');

    const doSearch = async () => {
        const formData = new FormData(tableHead.querySelector('form'));
        const formvals = {}
        for (const pair of formData.entries()) {
            formvals[pair[0]] = pair[1];
        }
        formvals.IsVisible = document.getElementById('IsVisible').checked;

        const query = Object.keys(formvals)
            .map(k => encodeURIComponent(k) + '=' + encodeURIComponent(formvals[k]))
            .join('&');

        const response = await fetch(query, { method: 'GET' });
        // const responseJson = await response.json();
        console.log('file-search', response);
    }
    ['change', 'paste', 'focusout', 'keyup']
        .forEach(ev => tableHead.addEventListener(ev, doSearch));

    document.addEventListener('DOMContentLoaded', doSearch);
})()