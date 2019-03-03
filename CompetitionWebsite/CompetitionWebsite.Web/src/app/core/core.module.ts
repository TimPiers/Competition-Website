import { NgModule, Optional, SkipSelf } from '@angular/core';

import { CommonModule } from '@angular/common';
import { SessionStorageService } from './services/session-storage.service';
import { BaseService } from './services/base.service';
import { GameService } from './services/Game.service';
import { BadgeService } from './services/badge.service';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [],
  providers: [
    BaseService,
    GameService,
    BadgeService,
    SessionStorageService
  ]
})
export class CoreModule {
  constructor(@Optional() @SkipSelf() parentModule: CoreModule) {
    if (parentModule) {
      throw new Error(
        'CoreModule is already loaded. Import it in the AppModule only');
    }
  }
}
