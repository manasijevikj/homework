$(document).ready(function () {

    let table = $("#result");
    let button = $("#showButton");
    let resultText = $("#resultText");

    let numOfCountries;
    let city = "tallinn";

    function findCurrency(data) {
        let currency = data.currencies[0].code;
        return currency;
    }

    function cityData(city) {
        return new Promise((resolve, reject) => {
            $.ajax({
                url: `https://restcountries.eu/rest/v2/capital/${city}`,
                success: function (response) {
                    resolve(response[0]);
                },
                error: function (errorResponse) {
                    reject(errorResponse);
                }
            })
        })
    };

    function numberOfCountries(currency) {
        return new Promise((resolve, reject) => {
            $.ajax({
                url: `https://restcountries.eu/rest/v2/currency/${currency}`,
                success: function (response) {
                    resolve(response.length);
                },
                error: function (errorResponse) {
                    reject(errorResponse);
                }
            })
        })
    };


    function createTable(data) {
        table.append(`<thead 
        <tr>
        <th scope="col">Name</th>
          <th scope="col">Capital</th>
          <th scope="col">Population</th>
          <th scope="col">Currencies</th>
          <th scope="col">Region</th>
          <th scope="col">Timezone</th>
          <th scope="col">CallingCodes</th>
        </tr>
        </thead>
        <tbody>
        <tr>
            <th scope="row">${data.name}</th>
            <td>${data.capital}</td>
            <td>${data.population}</td>
            <td>${data.currencies[0].code}</td>
            <td>${data.region}</td>
            <td>${data.timezones}</td>
            <td>${data.callingCodes}</td>
        </tr>
    </tbody>`)
    }



    async function mainFunction() {
        let cityInfo = await cityData(city);
        console.log(cityInfo);
        createTable(cityInfo)
        let currency = findCurrency(cityInfo);
        let number = await numberOfCountries(currency);
        numOfCountries = number;
    }

    mainFunction();

    button.click(function () {
        resultText.text("");
        resultText.text(`Number of countries using that currency: ${numOfCountries}`);
    })



})