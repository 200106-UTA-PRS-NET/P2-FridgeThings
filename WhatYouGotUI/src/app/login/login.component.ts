import { Component, OnInit } from '@angular/core';
//import { FormBuilder } from '@angular/forms';
//import {LoginService} from '../login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {

  
  //loginForm;  

  /*
  constructor(
    private loginService: LoginService,
    private formBuilder: FormBuilder,
  ) {
    this.loginForm = formBuilder.group({
      username: '',
      passphrase:''

    });
  }
  */
  constructor() { }
  ngOnInit(): void {
  }
  
  /*
  onSubmit(loginInfo){ 
    console.warn("Validating")
  }
  */

}
