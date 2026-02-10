// This validates price is positive 
function validatePrice(input){
    const priceInput = document.querySelector('input[name="Price"');
    if(priceInput && priceInput.value < 0)
    {
        alert('Price can not ne negative!');
        priceInput.value = 0;
        return false;
    }
    return true;
}

document.addEventListener('DOMContentLoaded', function()
{
    const priceInput = document.querySelector('input[name="Price"');
    if(priceInput){
        priceInput.addEventListener('blur', validatePrice);
    }
});