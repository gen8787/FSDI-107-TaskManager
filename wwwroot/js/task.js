class Task{
    constructor(taskId, title, important, startDate, dueDate, status, description) {
        this.taskId = taskId;
        this.title = title;
        this.important = important,
        this.startDate = new Date(startDate);
        this.dueDate = new Date (dueDate);
        this.status = status;
        this.description = description;
        this.user = "gary";
    }
}