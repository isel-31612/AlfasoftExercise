using System;

namespace AlfasoftExercise.StateModals
{
	public interface IStateModalsConverter<T>
	{
		public <T> getModel();
	}
}