async function downloadFileFromStream(filename, byteBase64) {
    var link = document.createElement('a');
    link.href = 'data:application/pdf;base64,' + byteBase64;
    link.download = filename;
    link.click();
}