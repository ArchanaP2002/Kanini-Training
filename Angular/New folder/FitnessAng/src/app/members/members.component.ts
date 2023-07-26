import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-members',
  templateUrl: './members.component.html',
  styleUrls: ['./members.component.css']
})
export class MembersComponent implements OnInit {
  public memberForm!: FormGroup;

  constructor(private formBuilder: FormBuilder, private authService: AuthService) {}

  ngOnInit(): void {
    this.initForm();
  }

  private initForm(): void {
    this.memberForm = this.formBuilder.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      phoneNumber: ['', Validators.required],
      comment: [''],
      acceptTerms: [false, Validators.requiredTrue]
    });
  }

  public submitMemberForm(): void {
    if (this.memberForm.invalid) {
      return;
    }

    this.authService.postUser(this.memberForm.value).subscribe(
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
