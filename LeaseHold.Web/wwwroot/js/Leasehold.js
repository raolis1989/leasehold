﻿$(document).ready(function () {

    var item_to_delete;
    var action_to_delete;

    $('.deleteImage').click((e) => {
        item_to_delete = e.currentTarget.dataset.id;
        action_to_delete = 1;

    });

    $('.deleteContract').click((e) => {
        item_to_delete = e.currentTarget.dataset.id;
        action_to_delete = 2;

    });

    $("#btnYesDelete").click(function () {
        if (action_to_delete == 1) {
            window.location.href = '../DeleteImage/' + item_to_delete;

        }
        else {
            window.location.href = '../DeleteContract/' + item_to_delete;
        }
    });
}); 