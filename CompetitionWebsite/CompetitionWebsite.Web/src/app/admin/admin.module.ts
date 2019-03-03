import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AdminComponent } from './admin.component';
import { AdminRoutingModule } from './admin-routing.module';
import { AdminHomePageComponent } from './admin-home-page/admin-home-page.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ManageGamesPageComponent } from './manage-games-page/manage-games-page.component';
import { ManageBadgesPageComponent } from './manage-badges-page/manage-badges-page.component';
import { ManageCompetitionPageComponent } from './manage-competitions/manage-competition-page/manage-competition-page.component';
import { NewCompetitionPageComponent } from './manage-competitions/new-competition-page/new-competition-page.component';


@NgModule({
  declarations: [
    AdminComponent,
    AdminHomePageComponent,
    ManageGamesPageComponent,
    ManageBadgesPageComponent,
    ManageCompetitionPageComponent,
    NewCompetitionPageComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AdminRoutingModule
  ],
  providers: [],
  bootstrap: [AdminComponent]
})
export class AdminModule { }
