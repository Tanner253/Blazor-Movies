function my_function(message) {
    console.log("from utilites " + message)
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount").then(result => {
        console.log("count from js " + result);
    })
}
function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}