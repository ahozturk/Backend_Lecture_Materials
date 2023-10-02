using ShapeAreaCalculator.Domain.Entities;
using ShapeAreaCalculator.Infrastructure.Services;

Console.WriteLine("Hello, World!");

Square square1 = new(4);

NotepadService notepadService = new();
notepadService.SaveToNotepad(square1);