(function (window, document, undefined) {
  window.onload = init;

  function init() {
    const inputElement = document.getElementById("fileUploader");
    inputElement.addEventListener("change", readXlsxFile, false);

    function readXlsxFile() {
      const selectedFile = document.getElementById("fileUploader").files[0];

      const reader = new FileReader();

      reader.onload = (event) => {
        const data = event.target.result;
        const workbook = XLSX.read(data, {
          type: "binary",
        });

        workbook.SheetNames.forEach(function (sheetName) {
          const XL_row_object = XLSX.utils.sheet_to_row_object_array(
            workbook.Sheets[sheetName]
          );
          const jsonData = JSON.parse(JSON.stringify(XL_row_object));
          plotAllData(jsonData);
        });
      };

      reader.onerror = function (event) {
        console.error(
          "File could not be read! Code " + event.target.error.code
        );
      };

      reader.readAsBinaryString(selectedFile);
    }
  }
})(window, document, undefined);
