using System;

namespace AlfasoftExercise.StateModals
{
	public interface IStateModalsConverter<T>
	{
		T getModel();
	}
}