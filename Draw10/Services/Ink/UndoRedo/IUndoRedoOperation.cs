namespace Draw10.Services.Ink.UndoRedo
{
    public interface IUndoRedoOperation
    {
        void ExecuteUndo();

        void ExecuteRedo();
    }
}
