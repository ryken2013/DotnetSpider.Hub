﻿using DotnetSpider.Enterprise.Application.TaskStatus.Dtos;
using System.Collections.Generic;

namespace DotnetSpider.Enterprise.Application.TaskHistory.Dtos
{
	public class TaskHistoryOutputDto
	{
		public long TaskId { get; set; }

		public string Identity { get; set; }

		public string CreationTime { get; set; }

		public List<TaskStatusOutputDto> Statuses { get; set; }
	}
}
