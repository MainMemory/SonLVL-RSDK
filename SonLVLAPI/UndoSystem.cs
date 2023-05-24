using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicRetro.SonLVL.API
{
	public abstract class UndoSystem
	{
		class UndoState
		{
			public string Name { get; }
			public byte[] Data { get; }

			public UndoState(string name, byte[] data)
			{
				Name = name;
				Data = data;
			}
		}

		private byte[] baseState = null;
		private readonly Stack<UndoState> undoStack = new Stack<UndoState>();
		private readonly Stack<UndoState> redoStack = new Stack<UndoState>();

		protected abstract byte[] GetState();
		protected abstract void ApplyState(byte[] state);

		public void Init()
		{
			baseState = GetState();
			undoStack.Clear();
			redoStack.Clear();
		}

		public bool CreateState(string name)
		{
			if (baseState == null)
				throw new InvalidOperationException("Undo system is not initialized!");
			byte[] data = GetState();
			if (data.FastArrayEqual(undoStack.Count == 0 ? baseState : undoStack.Peek().Data))
				return false;
			undoStack.Push(new UndoState(name, data));
			redoStack.Clear();
			return true;
		}

		public void Undo(int count = 1)
		{
			if (baseState == null)
				throw new InvalidOperationException("Undo system is not initialized!");
			if (count <= 0)
				return;
			while (count-- > 0 && undoStack.Count > 0)
				redoStack.Push(undoStack.Pop());
			ApplyState(undoStack.Count == 0 ? baseState : undoStack.Peek().Data);
		}

		public void Redo(int count = 1)
		{
			if (baseState == null)
				throw new InvalidOperationException("Undo system is not initialized!");
			if (count <= 0 || redoStack.Count == 0)
				return;
			while (count-- > 0 && redoStack.Count > 0)
				undoStack.Push(redoStack.Pop());
			ApplyState(undoStack.Peek().Data);
		}

		public bool CanUndo => baseState != null && undoStack.Count > 0;

		public bool CanRedo => baseState != null && redoStack.Count > 0;

		public int UndoCount => undoStack.Count;

		public int RedoCount => redoStack.Count;

		public IEnumerable<string> GetUndoNames() => undoStack.Select(a => a.Name);

		public IEnumerable<string> GetRedoNames() => redoStack.Select(a => a.Name);
	}
}
