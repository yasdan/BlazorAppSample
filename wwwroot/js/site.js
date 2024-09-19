<script>
    function showLoader() {
        // Show a loader (you can replace with any loader element you have)
        let loaderDiv = document.createElement("div");
    loaderDiv.id = "loader";
    loaderDiv.style.position = "fixed";
    loaderDiv.style.top = "50%";
    loaderDiv.style.left = "50%";
    loaderDiv.style.transform = "translate(-50%, -50%)";
    loaderDiv.style.border = "16px solid #f3f3f3";
    loaderDiv.style.borderTop = "16px solid #3498db";
    loaderDiv.style.borderRadius = "50%";
    loaderDiv.style.width = "120px";
    loaderDiv.style.height = "120px";
    loaderDiv.style.animation = "spin 2s linear infinite";
    document.body.appendChild(loaderDiv);

    // Hide the loader after 10 seconds
    setTimeout(function () {
        document.body.removeChild(loaderDiv);
    // Call the C# method when done
    DotNet.invokeMethodAsync('BlazorAppSample', 'OnLoadingComplete')
                    .then(data => console.log('Callback received'));
            }, 10000);
    }

    // For CSS Loader spinning animation
    const style = document.createElement('style');
    style.innerHTML = `
    @keyframes spin {
        0 % { transform: rotate(0deg); }
            100% {transform: rotate(360deg); }
        }`;
    document.head.appendChild(style);
</script>