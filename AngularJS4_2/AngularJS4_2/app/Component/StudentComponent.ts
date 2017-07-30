import { Component } from "@angular/core";
import { StudentModel } from "../Model/StudentModel";

@Component({
    selector: "app",
    templateUrl:"../../View/StudentTemplate.html"
})

export class StudentComponent {
    CurrentStudent: StudentModel = new StudentModel();
}