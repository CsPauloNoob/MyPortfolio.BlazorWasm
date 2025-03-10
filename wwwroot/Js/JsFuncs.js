//async function downloadFileFromStream(filename, byteBase64) {
//    var link = document.createElement('a');
//    link.href = 'data:application/pdf;base64,' + byteBase64;
//    link.download = filename;
//    link.click();
//}

function downloadFileFromUrl(filename, url) {
    var link = document.createElement('a');
    link.href = url;
    link.download = filename;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

window.copiarTexto = (id) => {
    let inputElement = document.getElementById(id);
    if (inputElement) {
        inputElement.focus();
        navigator.clipboard.writeText(inputElement.value).then(() => {
            console.log("Texto copiado!");
        }).catch(err => console.error(inputElement.value, err));
    }
}

