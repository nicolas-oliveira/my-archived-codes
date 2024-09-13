let initialState = true; // initial state of extension
let isWhiteList = false;
let over = false;
let status;
let params = {
    active: true,
    currentWindow: true
}

const inactiveOpacity = 0.3;
const overOpacity = 0.6;
const activeOpacity = 1;

const activeButton = document.querySelector("#active");
const desactiveButton = document.querySelector('#disable');
const domainButton = document.querySelector('.domain .button');
const domainBox = document.querySelector('.domain');
let tabDomain;

function checkWhitelist(){
    if(isWhiteList){
        status = "✗";
        domainButton.innerHTML = `${status} ${tabDomain}`;
        domainButton.style.opacity = inactiveOpacity;
        isWhiteList = false;
    } else {
        status = "✓";
        domainButton.innerHTML = `${status} ${tabDomain}`;
        domainButton.style.opacity = activeOpacity;
        isWhiteList = true;
    }
}

function toggleOpacity(elementToActivate, elementToDeactivate) {
    elementToActivate.style.opacity = activeOpacity;
    elementToDeactivate.style.opacity = inactiveOpacity;
}

function hoverAnimation(element) {
    element.addEventListener("mouseover", function(){
        if(element.style.opacity != 1) {
            element.style.opacity = overOpacity;
        }
    });
    element.addEventListener("mouseout", function(){
        if(element.style.opacity != 1) {
            element.style.opacity = inactiveOpacity;
        }
    });
}

if(initialState) {
    toggleOpacity(activeButton, desactiveButton);
    checkWhitelist();
    initialState = false;
}

activeButton.addEventListener("click", function() {
    toggleOpacity(activeButton, desactiveButton);
});

desactiveButton.addEventListener("click", function() {
    toggleOpacity(desactiveButton, activeButton);
});

domainBox.addEventListener("click", function() {
    checkWhitelist();
    sendRequest();
});

function sendRequest() {
    let request = {
        txt: "Fala"
    }
    chrome.tabs.query(params, ([currentTab]) => {
        chrome.tabs.sendMessage(currentTab.id, request);
    });
}

hoverAnimation(desactiveButton);
hoverAnimation(activeButton);
hoverAnimation(domainButton);

chrome.tabs.query(params, ([currentTab]) => {
    const url = new URL(currentTab.url);
    tabDomain = url.hostname;
    checkWhitelist();
});


