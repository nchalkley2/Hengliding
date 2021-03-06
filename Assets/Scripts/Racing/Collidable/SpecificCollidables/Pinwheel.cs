namespace Racing.Collidables {
	public class Pinwheel : Hinderance {

		private static readonly float BOOST_STRENGTH = 2f;

		public override void applySpecificEffect(Racer racer) {
			racer.adjustSpeed(Pinwheel.BOOST_STRENGTH);
		}
	}
}