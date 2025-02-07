async function downloadFileFromStream(filename, byteBase64) {
    var link = document.createElement('a');
    link.href = 'data:application/pdf;base64,' + byteBase64;
    link.download = filename;
    link.click();
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


//async function copyToClipBoard(text)
//{
//    navigator.clipboard.writeText(text).then(() => {
//        console.log("Copiado!");
//    }).catch(err => {
//        console.error("Erro ao copiar o texto", err);
//    });
//}