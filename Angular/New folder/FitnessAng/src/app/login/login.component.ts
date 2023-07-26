import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class loginComponent implements OnInit {
  public loginForm!: FormGroup;

  constructor(private formBuilder: FormBuilder, private authService: AuthService) {}

  ngOnInit(): void {
    this.initForm();
  }

  private initForm(): void {
    this.loginForm = this.formBuilder.group({
      // email: ['', [Validators.required, Validators.email]],
      email:[],
      password: ['']
    });
  }

  public submitLoginForm(): void {
   
    this.authService.postLogin(this.loginForm.value).subscribe(
      result => {
        alert("Added Successfully");
      },
      error => {
        console.error(error);
        alert("An error occurred while adding.");
      }
    );

    33

    
  }
}


