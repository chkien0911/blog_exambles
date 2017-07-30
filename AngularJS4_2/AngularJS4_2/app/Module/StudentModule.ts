import { BrowserModule } from "@angular/platform-browser";
import { FormsModule } from "@angular/forms";
import { NgModule } from "@angular/core";
import { StudentComponent } from "../Component/StudentComponent";

@NgModule({
    imports: [BrowserModule, FormsModule],
    declarations: [StudentComponent],
    bootstrap: [StudentComponent]
})

export class StudentModule {}
