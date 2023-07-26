import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { IndexComponent } from './index/index.component';
import { AboutusComponent } from './aboutus/aboutus.component';
import { MembersComponent } from './members/members.component';
import { PolicyComponent } from './policy/policy.component';
import { TermsComponent } from './terms/terms.component';
import { TrainerComponent } from './trainer/trainer.component';
import { WorkoutsComponent } from './workouts/workouts.component';
import { loginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
const routes: Routes = [
  {
    path: 'index', component: IndexComponent
  },
  {
    path: 'aboutus', component: AboutusComponent
  },
  {
    path: 'member', component: MembersComponent
  },
  { 
    path: 'policy', component: PolicyComponent
  },
  { 
    path: 'terms', component: TermsComponent
  },
  { 
    path: 'trainer', component: TrainerComponent
  },
  { 
    path: 'workouts', component: WorkoutsComponent
    },
  { 
    path: 'login', component: loginComponent
  },
  { 
    path: 'register', component: RegisterComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
