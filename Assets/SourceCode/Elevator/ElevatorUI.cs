using System;
using TMPro;
using UnityEngine;

public class ElevatorUI : MonoBehaviour
{
	public static Action<ElevatorUpgrade> OnUpgradeRequest;

	[SerializeField] private TextMeshProUGUI elevatorCollectorGold;
	private Elevator _elevator;
	private ElevatorUpgrade _elevatorUpgrade;

	private void Start() {
		_elevator = GetComponent<Elevator>();
		_elevatorUpgrade = GetComponent<ElevatorUpgrade>();
	}

	private void Update() {
		elevatorCollectorGold.text = _elevator.ElevatorCollector.currentGold.ToString();
	}

	public void RequestUpgrade() {
		OnUpgradeRequest.Invoke(_elevatorUpgrade);
	}
}