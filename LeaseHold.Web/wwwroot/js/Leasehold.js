$(document).ready(function () {

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

    $('.deleteItem').click((e) => {
        item_to_delete = e.currentTarget.dataset.id;
        action_to_delete = 3;

    });

    $('.deleteProperty').click((e) => {
        item_to_delete = e.currentTarget.dataset.id;
        action_to_delete = 4;

    });

    $('.deletePropertyType').click((e) => {
        item_to_delete = e.currentTarget.dataset.id;
        action_to_delete = 5;

    });
    

    $("#btnYesDelete").click(function () {
        switch (action_to_delete) {
            case 1:
                window.location.href = '../Owners/DeleteImage/' + item_to_delete;
                break;
            case 2:
                window.location.href = '../Owners/DeleteContract/' + item_to_delete;
                break;
            case 3:
                window.location.href = '~/../Owners/Delete/' + item_to_delete;
                break;
            case 4:
                window.location.href = '../DeleteProperty/' + item_to_delete;
                break;
            case 5:
                window.location.href = '~/../PropertyTypes/Delete/' + item_to_delete;
                break;
           

        }
         
    



        //if (action_to_delete == 1) {
        //    window.location.href = '../DeleteImage/' + item_to_delete;

        //}
        //else if(action_to_delete==2){
        //    window.location.href = '../DeleteContract/' + item_to_delete;
        //}
      
    });

    //$("#btnYesDeleteOwner").click(function () {
    //    window.location.href = '~/../Owners/Delete/' + item_to_delete;
   

    //});

    //$("#btnYesDeleteProperty").click(function () {
    //    window.location.href = '../DeleteProperty/' + item_to_delete;


    //});
}); 