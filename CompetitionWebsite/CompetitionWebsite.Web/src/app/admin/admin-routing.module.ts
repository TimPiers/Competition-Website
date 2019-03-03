import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './admin.component';
import { AdminHomePageComponent } from './admin-home-page/admin-home-page.component';
import { ManageGamesPageComponent } from './manage-games-page/manage-games-page.component';
import { ManageBadgesPageComponent } from './manage-badges-page/manage-badges-page.component';
import { ManageCompetitionPageComponent } from './manage-competitions/manage-competition-page/manage-competition-page.component';
import { NewCompetitionPageComponent } from './manage-competitions/new-competition-page/new-competition-page.component';

const routes: Routes = [
  {
    path: 'admin',
    component: AdminComponent,
    children: [
      { path: '', component: AdminHomePageComponent },
      { path: 'manage/games', component: ManageGamesPageComponent },
      { path: 'manage/badges', component: ManageBadgesPageComponent },
      { path: 'manage/competitions', component: ManageCompetitionPageComponent },
      { path: 'manage/competitions/new', component: NewCompetitionPageComponent }
    ]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AdminRoutingModule { }
