﻿using SpaceShip.Service.Contracts;

namespace SpaceShip.Service.Interfaces
{
    /// <summary>
    /// Interface for working with problem.
    /// </summary>
    public interface IProblemService
    {
        /// <summary>
        /// Create a problem.
        /// </summary>
        ProblemDTO CreateProblem();

        /// <summary>
        /// Retrieve the problem by <paramref name="problemId"/>.
        /// </summary>
        ProblemDTO GetProblem(Guid problemId);

        /// <summary>
        /// Update the problem with <paramref name="problemId"/>.
        /// </summary>
        ProblemDTO UpdateProblem(Guid problemId, ProblemDTO problemDTO);

        /// <summary>
        /// Delete the problem with <paramref name="problemId"/>.
        /// </summary>
        bool DeleteProblem(Guid problemId);
    }
}
