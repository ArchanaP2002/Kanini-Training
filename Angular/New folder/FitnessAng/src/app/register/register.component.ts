import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})

export class RegisterComponent implements OnInit {
  public registerForm!: FormGroup;

  constructor(private formBuilder: FormBuilder, private authService: AuthService) {}

  ngOnInit(): void {
    this.initForm();
  }

  private initForm(): void {
    this.registerForm = this.formBuilder.group({
      name: [],
      contactNumber:[],
      email: [],
      password: []
    });
  }

  public submitRegisterForm(): void {
    // if (this.registerForm.invalid) {
    //   return;
    // }

    this.authService.postRegister(this.registerForm.value).subscribe(
      result => {
        alert("Added Successfully");
      },
      error => {
        console.error(error);
        alert("An error occurred while adding.");
      }
    );
  }
}


