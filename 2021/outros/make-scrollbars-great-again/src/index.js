// document.addEventListener('DOMContentLoaded', function() {
//     OverlayScrollbars(
//         document.querySelectorAll('body'),{}
//     );
// });
chrome.runtime.onMessage.addListener(function(request, sender, sendResponse) {
    console.log(request);
});