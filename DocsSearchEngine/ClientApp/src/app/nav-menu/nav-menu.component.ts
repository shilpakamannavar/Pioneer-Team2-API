import { Component } from '@angular/core';
import { SearchDocsService } from '../shared/search-docs.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

    constructor(private searchDocsService:SearchDocsService) { }
    isExpanded = false;
    searchQuery: string = "";

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
    }

    onSearch() {
        this.searchDocsService.GetResults(this.searchQuery);
    }
}
