function buttonOnClick(event, arguments){
    var userWindow = window;
    var userBrowser = userWindow.navigator.appCodeName;
    var isMozilla = (userBrowser == 'Mozilla');
    if(isMozilla){
         alert('Yes it is Mozilla!');
    }
    else{
        alert('No it is not Mozilla!');
    }
}