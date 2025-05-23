﻿using MMCourseStore.Framework.Domain;

namespace MMCourseStore.Modules.Courses.Domain;
public record CourseMetaDataChangedDomainEvent(long Id,
                                       string Title,
                                       string Description,
                                       DateTime StartDate,
                                       int SessionCount) : IDomainEvent;