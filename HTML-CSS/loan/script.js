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

  function confirmpassword(){
    let entered_password = document.getElementById("pwd");
    let entered_confpwd = document.getElementById("conpwd");
  
    if (entered_confpwd.value == "") {
      entered_confpwd.classList.remove("valid");
      entered_confpwd.classList.add("invalid");
      document.getElementById("result").innerHTML = "Please enter a valid confirm password";
      entered_confpwd.focus();
    } else if (entered_password.value != entered_confpwd.value) {
      entered_confpwd.classList.remove("valid");
      entered_confpwd.classList.add("invalid");
      document.getElementById("result").innerHTML = "Passwords do not match";
      entered_confpwd.focus();
    } else {
      entered_confpwd.classList.remove("invalid");
      entered_confpwd.classList.add("valid");
    }
  }
  
    
  
  function passwordvalidation(){
    var entered_password= document.getElementById("pwd");
     // Validate lowercase letters
  var lowerCaseLetters = /[a-z]/g;
  if(entered_password.value.match(lowerCaseLetters)) {  
    entered_password.classList.remove("invalid");
    entered_password.classList.add("valid");
  } else {
    entered_password.classList.remove("valid");
    entered_password.classList.add("invalid");
    document.getElementById("result").innerHTML =
        "Please enter valid Credentials";
    entered_password.focus();
  }
  
  // Validate capital letters
  var upperCaseLetters = /[A-Z]/g;
  if(entered_password.value.match(upperCaseLetters)) {  
    entered_password.classList.remove("invalid");
    entered_password.classList.add("valid");
  } else {
    entered_password.classList.remove("valid");
    entered_password.classList.add("invalid");
    document.getElementById("result").innerHTML =
    "Please enter valid Credentials";
entered_password.focus();
  }

  // Validate numbers
  var numbers = /[0-9]/g;
  if(entered_password.value.match(numbers)) {  
    entered_password.classList.remove("invalid");
    entered_password.classList.add("valid");
  } else {
    entered_password.classList.remove("valid");
    entered_password.classList.add("invalid");
    document.getElementById("result").innerHTML =
    "Please enter valid Credentials";
entered_password.focus();
  }
  
  // Validate length
  if(entered_password.value.length >= 8) {
    entered_password.classList.remove("invalid");
    entered_password.classList.add("valid");
  } else {
    entered_password.classList.remove("valid");
    entered_password.classList.add("invalid");
    document.getElementById("result").innerHTML =
    "Please enter valid Credentials";
entered_password.focus();
  }
}
  
  function myfunction(){
    // alert("Registered Sucessfully");
    //         location.href="login.html";
  }
  function myfunc(){
    // alert("Welcome");
    // location.href="index.html";
        }  