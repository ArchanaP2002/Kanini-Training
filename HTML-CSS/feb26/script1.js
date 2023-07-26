function validateName() {
  var entered_name = document.getElementById("name");
  var regName = /^[A-Za-z\s]*$/;
  if (entered_name.value == "" || !entered_name.value.match(regName)) {
    entered_name.classList.remove("valid");
    entered_name.classList.add("invalid");
    document.getElementById("result").innerHTML =
      "Please enter valid Credentials";
    entered_name.focus();
  } else {
    entered_name.classList.remove("invalid");
    entered_name.classList.add("valid");
  }
}

function validateContactNo() {
  var re = /^\(?(\d{3})\)?[- ]?(\d{3})[- ]?(\d{4})$/;
  var entered_phnumber = document.getElementById("phoneNumber");
  if (entered_phnumber.value.match(re)) {
    entered_phnumber.classList.remove("invalid");
    entered_phnumber.classList.add("valid");
  } else {
    entered_phnumber.classList.remove("valid");
    entered_phnumber.classList.add("invalid");
    document.getElementById("result").innerHTML =
      "Please enter valid Credentials";
    entered_phnumber.focus();
  }
}

function emailValidation() {
  var entered_email = document.getElementById("emailId");
  var validRegex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
  if (entered_email.value.match(validRegex)) {
    entered_email.classList.remove("invalid");
    entered_email.classList.add("valid");
  } else {
    entered_email.classList.remove("valid");
    entered_email.classList.add("invalid");
    document.getElementById("result").innerHTML =
      "Please enter valid Credentials";
    entered_email.focus();
  }
}


function myfunction(){
  alert("Registered Sucessfully");
          location.href="login.html";
}
function myfunc(){
  alert("Welcome");
  location.href="feb26.html";
      }

// var comboPrices = {
//   offer1: 799,
//   offer2: 899,
//   offer3: 1199,
//   offer4: 299,
//   offer5: 999,
// };

// function calculation() {
//   //   validateName();
//   //   validateContactNo();
//   //   emailValidation();
//   //   validateAddress();
//   var checkCombo1 = document.getElementById("offer1").checked;
//   var checkCombo2 = document.getElementById("offer2").checked;
//   var checkCombo3 = document.getElementById("offer3").checked;
//   var checkCombo4 = document.getElementById("offer4").checked;
//   var checkCombo5 = document.getElementById("offer5").checked;
//   var Price = 0;
//   if (checkCombo1 || checkCombo2 || checkCombo3 || checkCombo4 || checkCombo5) {
//     if (checkCombo1) {
//       Price += comboPrices.offer1;
//     }
//     if (checkCombo2) {
//       Price += comboPrices. offer2;
//     }
//     if (checkCombo3) {
//       Price += comboPrices. offer3;
//     }
//     if (checkCombo4) {
//       Price += comboPrices. offer4;
//     }
//     if (checkCombo5) {
//       Price += comboPrices. offer5;
//     }
//     if (Price >= 2000) {
//       var discount = (Price * 20) / 100;
//       var netPrice = Price - discount;
//       document.getElementById("result").innerHTML =
//         "Order has been placed successfully. You are requested to pay Rs." +
//         Math.round(netPrice) +
//         " on delivery.";
//     } else {
//       document.getElementById("result").innerHTML =
//         "Order has been placed successfully. You are requested to pay Rs." +
//         Math.round(Price) +
//         " on delivery.";
//     }
//   } else {
//     document.getElementById("result").innerHTML = "No selection has been made.";
//   }

