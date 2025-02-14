async function downloadFileFromStream(filename, byteBase64) {
    var link = document.createElement('a');
    link.href = 'data:application/pdf;base64,' + byteBase64;
    link.download = filename;
    link.click();
}


function copyToClipboard(text)
{
    navigator.clipboard.writeText(text).then(() => {
        console.log("Texto copiado!");
    }).catch(err => {
        console.error("Erro ao copiar texto:", err);
    });
}
