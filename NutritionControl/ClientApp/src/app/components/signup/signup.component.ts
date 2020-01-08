//////import { AlertifyService } from '../../../services/alertify.service';
//////import { User } from '../../../models/user';
//////import { AuthenticationService } from '../../../services/authentication.service';
////import { Component, OnInit } from '@angular/core';
////import { Router } from '@angular/router';
////import { FormBuilder, FormGroup, Validators } from '@angular/forms';
//////import { UserForRegister } from 'src/app/interfaces/UserForRegister';

//@Component({
//  selector: 'app-signup',
//  templateUrl: './signup.component.html',
//  styleUrls: ['./signup.component.css']
//})
//export class SignupComponent implements OnInit {
//  //user: UserForRegister;
//  //registerForm: FormGroup;

//  constructor(private router: Router,
//    private authService: AuthenticationService,
//    private fb: FormBuilder,
//    private alertify: AlertifyService) { }

//  ngOnInit() {
//    this.createRegisterForm();
//  }

////  createRegisterForm() {
////    this.registerForm = this.fb.group({
////      isEmployer: ['', Validators.required],
////      input: ['', Validators.compose([Validators.required,
////      Validators.pattern(/^([_a-z0-9]+(\.[_a-z0-9]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,5}))|(\d+$)$/)])],
////      password: ['', [Validators.required, Validators.minLength(6), Validators.maxLength(10)]],
////      confirmPassword: ['', Validators.required]
////    }, { validator: this.passwordMatchValidator });
////  }

////  passwordMatchValidator(g: FormGroup) {
////    return g.get('password').value === g.get('confirmPassword').value ? null : { 'missmatch': true };
////  }

////  register() {
////    if (this.registerForm.valid) {
////      this.user = Object.assign({}, this.registerForm.value);
////      this.authService.register(this.user).subscribe(() => {
////        this.alertify.success('Registration successful');
////      }, error => {
////        this.alertify.error(error);
////      }, () => {
////        this.authService.login(this.user).subscribe(() => {
////          //if (this.authService.hasAdminRole()) {
////          //  this.router.navigate(['/admin']);
////          //}          
////          //else {
////            this.router.navigate(['/profile']);
////          //}
////        });
////      });
////    }
////  }

////  cancel() {
////    this.user = null;
////    this.router.navigate(['/']);
////  }

//}
