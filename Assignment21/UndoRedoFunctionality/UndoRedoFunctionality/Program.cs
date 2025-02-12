using System;
namespace UndoRedoFunctionality
{ 
    class TextEditorState
    {
        public string Content;
        public TextEditorState Prev;
        public TextEditorState Next;

        public TextEditorState(string content)
        {
            Content = content;
            Prev = null;
            Next = null;
        }
    }

    class TextEditor
    {
        private TextEditorState head;  
        private TextEditorState current;  
        private int maxHistory = 10;  
        private int count = 0;

        public TextEditor()
        {
            head = null;
            current = null;
        }

      
        public void AddState(string content)
        {
            TextEditorState newState = new TextEditorState(content);

            if (current == null)
            {
                head = newState;
                current = newState;
            }
            else
            {
              
                current.Next = null;

                
                newState.Prev = current;
                current.Next = newState;
                current = newState;

              
                if (count >= maxHistory)
                {
                    head = head.Next;
                    head.Prev = null;
                }
                else
                {
                    count++;
                }
            }
        }

        
        public void Undo()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
            }
        }

       
        public void Redo()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
            }
        }

     
        public void DisplayCurrentState()
        {
            if (current != null)
            {
                Console.WriteLine("Current Text: " + current.Content);
            }
            else
            {
                Console.WriteLine("No text available.");
            }
        }
    }

    
    class Program
    {
        static void Main()
        {
            TextEditor editor = new TextEditor();

            editor.AddState("Hello");
            editor.AddState("Hello, World!");
            editor.AddState("Hello, World! How are you?");

            editor.DisplayCurrentState();  

            editor.Undo();
            editor.DisplayCurrentState();  

            editor.Undo();
            editor.DisplayCurrentState();  

            editor.Redo();
            editor.DisplayCurrentState();  
        }
    }

}