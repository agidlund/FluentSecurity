using FluentSecurity.Policy;
using NUnit.Framework;

namespace FluentSecurity.Specification
{
	[TestFixture]
	[Category("PolicyViolationExceptionSpec")]
	public class When_creating_a_PolicyViolationException
	{
		[Test]
		public void Should_have_PolicyResult_PolicyType_and_Message_set()
		{
			// Arrange
			var policy = new DenyAnonymousAccessPolicy();
			var policyResult = PolicyResult.CreateFailureResult(policy, "Anonymous access denied");

			// Act
			var exception = new PolicyViolationException(policyResult);

			// Assert
			Assert.That(exception.PolicyResult, Is.EqualTo(policyResult));
			Assert.That(exception.PolicyType, Is.EqualTo(typeof(DenyAnonymousAccessPolicy)));
			Assert.That(exception.Message, Is.EqualTo("Anonymous access denied"));
		}
	}
}