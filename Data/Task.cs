namespace ToDoList.Data;
public class Task
{
    public string Id { get; set; }
    public int SortId { get; set; }
    public string WhatToDo { get; set; }
    public bool isDone { get; set; }
    public bool isDisabled { get; set; }
}