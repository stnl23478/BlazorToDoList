namespace ToDoList.Data;
public class Task
{
    public string Id { get; set; }
    public DateTime WhenAdded { get; set; }
    public string WhatToDo { get; set; }
    public bool isDone { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
}