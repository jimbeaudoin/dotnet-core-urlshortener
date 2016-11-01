var contentContainer = document.getElementById("content-container");
var currentHref = `${window.location.protocol}//${window.location.host}/`;

var Ajax = {
    call(method, url, data, cfunc) {
        var xhttp = new XMLHttpRequest();

        xhttp.onreadystatechange = function () {
            if (xhttp.readyState === 4 && (xhttp.status === 200 || xhttp.status === 201)) {
                if (cfunc) {
                    cfunc(xhttp);
                }
            }
        };

        xhttp.open(method, url, true);
        xhttp.setRequestHeader("Content-Type", "application/json");
        xhttp.send(data);
    }
};

var Renderer = {
    createBtnElement() {
        var element = document.createElement("button");
        element.innerText = "Shorten";

        // Add button click event listener
        element.addEventListener("click", function (e) {
            if (inputElement.value !== "") {
                var data = JSON.stringify({
                    "longFormat": inputElement.value
                });
                
                // Ask API to shorten URL
                Ajax.call("POST", `${currentHref}api/urls`, data, function (xhttpRequest) {
                    var urlItem = JSON.parse(xhttpRequest.response);
                    contentContainer.appendChild(Renderer.createUrlElement(urlItem));
                });
            }
        });

        return element;
    },

    createInputElement() {
        var element = document.createElement("input");
        element.type = "text";
        element.id = "txtUrl";
        return element;
    },

    createUrlElement(item) {
        var template = document.createElement("div");
        var href = `${currentHref}?q=${item.shortFormat}`;
        template.innerHTML = `<h4>Your short url is: <a href='${href}'>${href}</a></h4>`;
        return template;
    }
};

var Initializer = {
    getParam(name) {
        // Source: http://stackoverflow.com/a/5158301/3995856
        var match = RegExp('[?&]' + name + '=([^&]*)').exec(window.location.search);
        return match && decodeURIComponent(match[1].replace(/\+/g, ' '));
    },

    initPage() {
        var param = Initializer.getParam("q");
        if (param === null) {
            contentContainer.insertBefore(btnElement, contentContainer.firstChild);
            contentContainer.insertBefore(inputElement, contentContainer.firstChild);
        }
        else {
            // Ask API for long format and redirect
            Ajax.call("GET", `${currentHref}api/urls/${param}`, null, function (xhttpRequest) {
                var responseJSON = JSON.parse(xhttpRequest.response);
                window.location.href = responseJSON.longFormat;
            });
        }
    }
}

var btnElement = Renderer.createBtnElement();
var inputElement = Renderer.createInputElement();
Initializer.initPage();