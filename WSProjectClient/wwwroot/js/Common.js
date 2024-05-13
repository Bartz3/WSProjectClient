//const { error } = require("jquery");
//const { success } = require("toastr");

window.ShowToastr = (type, message) => {
    toastr.options.toastClass = "toastr";

    if (type == success) {
        toastr.success(message, "Success!", { timeOut: 20000 });
    }
    if (type == error) {
        toastr.error(message, "Operation failed", { timeOut:20000 });
    }
}