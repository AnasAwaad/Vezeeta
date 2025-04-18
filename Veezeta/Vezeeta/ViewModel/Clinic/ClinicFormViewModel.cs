﻿namespace Vezeeta.Presentation.ViewModel.Clinic;
public class ClinicFormViewModel
{
	public int? Id { get; set; }
	public string Name { get; set; } = null!;
	public string Location { get; set; } = null!;
	public bool IsDeleted { get; set; }
	public DateTime? LastUpdatedOn { get; set; }
}
