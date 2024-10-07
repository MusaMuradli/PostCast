using AutoMapper;
using Podcast.BLL.Services.Contracts;
using Podcast.BLL.ViewModels.TopicViewModels;
using Podcast.DAL.DataContext.Entities;
using Podcast.DAL.Repositories.Contracts;

namespace Podcast.BLL.Services;

public class TopicManager : CrudManager<Topic, TopicViewModel, TopicCreateViewModel, TopicUpdateViewModel>, ITopicService
{
    private readonly ITopicRepository _topicRepository;
    public TopicManager(IRepositoryAsync<Topic> repository, IMapper mapper, ITopicRepository topicRepository) : base(repository, mapper)
    {
        _topicRepository = topicRepository;
    }


    
}