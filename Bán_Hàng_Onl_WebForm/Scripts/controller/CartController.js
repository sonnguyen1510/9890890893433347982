var cart = {
    init: function () {
        cart.regEvent();
    },
    regEvent: function () {
        $('#btnContinue').off('click').on('click', function () {
            window.location.href = "/";
        });

        $('#btnUpdate').off('click').on('click', function () {
            var listProduct = $('.Quantity');
            var cartList = [];
            $.each(listProduct, function (i, item) {
                cartList.push({
                    Quantity: $(item).val(),
                    Product: {
                        productID: $(item).data('id')
                    }
                });
            });
            $.ajax({
                url: '/Cart/Update',
                data: {
                    CartModel: JSON.stringify(cartList)
                },
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/Cart";
                    }
                }
            })
        });


        $('#btnDelete').off('click').on('click', function () {
            $.ajax({
                url: '/Cart/DeleteAll',
                dataType: 'json',
                type: 'POST',
                success: function (res) {
                    if (res.status == true) {
                        window.location.href = "/Cart";
                    }
                }
            })
        });

        $('btnPayment').off('click').on('click', function () {
            window.location.href = "/Cart/payment";
        });
    }
}
cart.init();