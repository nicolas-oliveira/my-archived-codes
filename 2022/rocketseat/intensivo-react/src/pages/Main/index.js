import React, { Component } from 'react';
import { FaGithubAlt, FaPlus, FaSpinner } from 'react-icons/fa';
import { Link } from 'react-router-dom';

import api from '../../services/api';

import { Form, SubmitButton, List } from './styles';

import Container from '../../components/Container';

export default class Main extends Component {
	state = {
		newRepo: '',
		repositories: [],
		loading: false,
		error: false,
	};

	componentDidMount() {
		const repositories = localStorage.getItem('repositories');
		if (repositories) {
			this.setState({ repositories: JSON.parse(repositories) });
		}
	}

	componentDidUpdate(foo, prevState) {
		const { repositories } = this.state;

		if (prevState.repositories !== repositories) {
			localStorage.setItem('repositories', JSON.stringify(repositories));
		}
	}

	handleInputChange = (e) => {
		this.setState({ newRepo: e.target.value });
	};

	handleSubmit = async (e) => {
		try {
			e.preventDefault();

			const { newRepo, repositories } = this.state;

			repositories.forEach((name) => {
				if (name === newRepo) {
					throw new Error('Repositório duplicado');
				}
			});

			this.setState({ loading: true });

			const response = await api.get(`/repos/${newRepo}`);

			const data = {
				name: response.data.full_name,
			};

			this.setState({
				repositories: [...repositories, data],
				newRepo: '',
				loading: false,
				error: false,
			});
		} catch {
			this.setState({
				loading: false,
				error: true,
			});
		}
	};

	render() {
		const { newRepo, repositories, loading, error } = this.state;

		return (
			<Container>
				<h1>
					<FaGithubAlt />
					Repositorios
				</h1>
				<span>Este repositório já existe </span>
				<Form onSubmit={this.handleSubmit} error={error}>
					<input
						type="text"
						placeholder="Adicionar repo"
						value={newRepo}
						onChange={this.handleInputChange}
					/>

					<SubmitButton loading={loading}>
						{loading ? (
							<FaSpinner color="#fff" size={14} />
						) : (
							<FaPlus color="#fff" size={14} />
						)}
					</SubmitButton>
				</Form>

				<List>
					{repositories.map((repository) => (
						<li key={repository.name}>
							<span>{repository.name}</span>
							<Link to={`/repository/${encodeURIComponent(repository.name)}`}>
								Detalhes
							</Link>
						</li>
					))}
				</List>
			</Container>
		);
	}
}
