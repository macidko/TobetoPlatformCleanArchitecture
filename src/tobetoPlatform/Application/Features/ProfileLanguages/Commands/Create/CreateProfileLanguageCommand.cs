using Application.Features.ProfileLanguages.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ProfileLanguages.Commands.Create;

public class CreateProfileLanguageCommand : IRequest<CreatedProfileLanguageResponse>
{
    public int UserProfileId { get; set; }
    public int LanguageId { get; set; }

    public class CreateProfileLanguageCommandHandler : IRequestHandler<CreateProfileLanguageCommand, CreatedProfileLanguageResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProfileLanguageRepository _profileLanguageRepository;
        private readonly ProfileLanguageBusinessRules _profileLanguageBusinessRules;

        public CreateProfileLanguageCommandHandler(IMapper mapper, IProfileLanguageRepository profileLanguageRepository,
                                         ProfileLanguageBusinessRules profileLanguageBusinessRules)
        {
            _mapper = mapper;
            _profileLanguageRepository = profileLanguageRepository;
            _profileLanguageBusinessRules = profileLanguageBusinessRules;
        }

        public async Task<CreatedProfileLanguageResponse> Handle(CreateProfileLanguageCommand request, CancellationToken cancellationToken)
        {
            ProfileLanguage profileLanguage = _mapper.Map<ProfileLanguage>(request);

            await _profileLanguageRepository.AddAsync(profileLanguage);

            CreatedProfileLanguageResponse response = _mapper.Map<CreatedProfileLanguageResponse>(profileLanguage);
            return response;
        }
    }
}